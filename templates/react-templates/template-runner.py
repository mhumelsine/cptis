import os
import re

from jinja2 import Environment, FileSystemLoader
import yaml

def label_name(value:str):
    split = re.sub('([A-Z][a-z]+)', r' \1', value).split()

    for index, s in enumerate(split):
        if index == 0:
            split[index] = s.title()
        else:
            split[index] = s.lower()

    return ' '.join(split)



if __name__ == "__main__":

    content = None

    with open("./forms.yml", encoding="utf-8-sig") as f:
        try:
            content = yaml.safe_load(f)
        except yaml.YAMLError as e:
            print(e)

    # Configure Jinja environment
    env = Environment(
        loader=FileSystemLoader('./templates', encoding='utf-8-sig'),
        lstrip_blocks=True,
        trim_blocks=True
    )
    env.filters['label_name'] = label_name
    env.globals.update(env.get_template('./macros.j2').module.__dict__)

    os.makedirs('./output', exist_ok=True)
    os.makedirs('./output/spa', exist_ok=True)
    os.makedirs('./output/api', exist_ok=True)

    for entity_name in content.keys():
        os.makedirs(f'./output/spa/{entity_name}', exist_ok=True)

        print(f'Entity: {entity_name}')
        for page in content[entity_name]['pages']:
            print(f'Page: {page}')

            with open(f'./output/spa/{entity_name}/{page.title()}.tsx', "w+") as component:
                template_name = f'{page}.j2'
                template = env.get_template(template_name)

                component.write(template.render(content[entity_name]['fields']))

            with open(f'./output/spa/{entity_name}/types.ts', "a+") as model_type:
                template = env.get_template('typescript_type.j2')

                type_model = {
                    'entity_name': entity_name,
                    'screen_type': page,
                    'fields': content[entity_name]['fields']
                }

                model_type.write(template.render(type_model))

    exit(0)
