﻿using SuperHeroes.clases;

Superman superM = new Superman();

superM.Fuerza = 150;
superM.Nombre = "Clark Kent";
superM.agilidad = 100;
//superM.presentarse();
//superM.salvarElMundo();
//superM.volar();

//Console.WriteLine("Superman tiene una fuera de {0}", superM.Fuerza);
//Console.WriteLine("Superman se llama {0}", superM.Nombre);

SuperHeroesDB SuperH = new SuperHeroesDB();
SuperH.CrearTablaHeroe();