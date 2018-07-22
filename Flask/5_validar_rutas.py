# http://flask.pocoo.org/docs/1.0/installation/#installation
from flask import Flask
from flask import request

# Nuevo objeto
app = Flask(__name__)

# http://localhost:8000/params?params1=daniel&params2=Ramos
@app.route('/')
def index():
	return 'Hola Mundo'

@app.route('/params/')
@app.route('/params/<name>/')
#@app.route('/params/<name>/<last_name>')
@app.route('/params/<name>/<int:num>')
#def params(name='Valor por defecto - name', last_name='valor por defecto - last_name', num='nada'):
def params(name='Valor por defecto - name', num='nada'):
	#return 'El parametro es: {} {}'.format(name, last_name)
	return 'El parametro es: {} {}'.format(name, num)

# Ejecuta el servidor
if __name__ == '__main__': 
	app.run(debug= True, port = 8000)