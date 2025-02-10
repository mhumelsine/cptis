import os

from jinja2 import Environment, FileSystemLoader
import yaml

content = None

with open("./forms.yml", encoding="utf-8-sig") as f:
    try:
        content = yaml.safe_load(f)
    except yaml.YAMLError as e:
        print(e)

# Configure Jinja environment
env = Environment(
    loader=FileSystemLoader('./templates', encoding='utf-8-sig'),
)
#for module in env.get_template('./macros.j2').module:

env.globals.update(env.get_template('./macros.j2').module.__dict__)

os.makedirs('./output', exist_ok=True)
os.makedirs('./output/spa', exist_ok=True)
os.makedirs('./output/api', exist_ok=True)

for entity_name in content.keys():
    os.makedirs(f'./output/spa/{entity_name}', exist_ok=True)

    print(f'Entity: {entity_name}')
    for screen_type in content[entity_name].keys():
        print(f'Screen: {screen_type}')
        template_name = f'{screen_type}.j2'
        template = env.get_template(template_name)

        output = template.render(content[entity_name][screen_type])

        with open(f'./output/spa/{entity_name}/{screen_type}.tsx', "w") as component:
            component.write(output)

exit(0)