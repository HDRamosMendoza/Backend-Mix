#!/usr/bin/env python
# -*- coding: utf-8 -*-
from flask import Flask
from flask import render_template

app = Flask(__name__, template_folder = "templates2")

# Flask trabaja con jinja2
@app.route('/')
def index():
	name = 'Eduardo'
	return render_template('index.html', name=name)

# Ejecuta el servidor
if __name__ == '__main__': 
	app.run(debug= True, port = 8000)