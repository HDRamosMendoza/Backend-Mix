#!/usr/bin/env python
# -*- coding: utf-8 -*-
from flask import Flask
from flask import render_template

app = Flask(__name__)

# Flask trabaja con jinja2
@app.route('/')
def index():
	name = 'Eduardo'
	return render_template('base/index.html', name=name)

@app.route('/client')
def client():
	list_name = ['Test1', 'Test2', 'Test3']
	return render_template('client.html', list=list_name)

# Ejecuta el servidor
if __name__ == '__main__': 
	app.run(debug= True, port = 8000)