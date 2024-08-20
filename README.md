# Earth Orbit Simulator

This project uses Newtonian physics with Unity's physics system to simulate Earth orbit. The trickiest part is getting the units correct. You can't use normal SI units because Unity / PhysX has a maximum limit on mass which is smaller than the mass of the Earth in kg.

Instead this project uses astronomical units (AU) for distances, solar masses for mass (the solar mass of the Sun is 1 by definition,) and years for time instead of seconds.

The included spreadsheet contains the working out for the values in these units.