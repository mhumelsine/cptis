from jinja2 import Environment, FileSystemLoader
import yaml

content = None

with open("./forms.yml") as f:
    try:
        content = yaml.safe_load(f)
    except yaml.YAMLError as e:
        print(e)

# Configure Jinja environment
env = Environment(
    loader=FileSystemLoader('./templates')
)
#for module in env.get_template('./macros.j2').module:

env.globals.update(env.get_template('./macros.j2').module.__dict__)

for entity_name in content.keys():
    print(f'Entity: {entity_name}')
    for screen_type in content[entity_name].keys():
        print(f'Screen: {screen_type}')
        template_name = f'{screen_type}.j2'
        template = env.get_template(template_name)

        output = template.render(content[entity_name][screen_type])

        # Print the output
        print(output)

exit(0)