#!/usr/bin/env python
# -*- coding: utf-8 -*-
from flask import Flask
from flask import render_template

app = Flask(__name__)
#app = Flask(__name__, template_folder = "carpeta_template")
#La carpeta por defecto es "templates"
#template_folder = "template"

# Flask trabaja con jinja2
@app.route('/')
def index():
	return render_template('index.html')

# Ejecuta el servidor
if __name__ == '__main__': 
	app.run(debug= True, port = 8000)