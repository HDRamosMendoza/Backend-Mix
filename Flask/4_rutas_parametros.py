# http://flask.pocoo.org/docs/1.0/installation/#installation
from flask import Flask
from flask import request

# Nuevo objeto
app = Flask(__name__)

# http://localhost:8000/params?params1=daniel&params2=Ramos
@app.route('/')
def index():
	return 'Hola Mundo'

# Decorador 
@app.route('/saluda')
def saluda():
	param = request.args.get('param1', 'no contiene este parametro')
	return 'El parametro es {}'.format(param)

@app.route('/params')
def params():
	param_1 = request.args.get('param1', 'no contiene este parametro')
	param_2 = request.args.get('param2', 'no contiene este parametro')
	return 'El parametro es: {} ,{}'.format(param_1, param_2)

# Ejecuta el servidor
if __name__ == '__main__': 
	app.run(debug= True, port = 8000)