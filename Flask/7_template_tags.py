#!/usr/bin/env python
# -*- coding: utf-8 -*-
from flask import Flask
from flask import render_template

app = Flask(__name__)

# Flask trabaja con jinja2
# Puedes enviar diccionarios tuplas ...
@app.route('/user/<name>')
def user(name='Eduardo'):
	age= 25
	my_list = [1,2,3,4,5,6,7,8]
	return render_template('user.html', nombre=name, age=age, list=my_list)

# Ejecuta el servidor
if __name__ == '__main__': 
	app.run(debug= True, port = 8000)