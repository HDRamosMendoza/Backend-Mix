from flask import Flask
#http://flask.pocoo.org/docs/1.0/installation/#installation

# Nuevo objeto
app = Flask(__name__)

# Decorador 
@app.route('/')
def inde():
	return 'Hola Mundo'

# Ejecuta el servidor 
app.run()