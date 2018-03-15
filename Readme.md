
# Raycare Hospital Simulator

This supports basic patient registration and scheduling via a command line interface (console application).

The initialization data is present in Resources/InitialHospitalData.json

## How To Run

Open in **Visual Studio**. Press ctrl+f5 to make a release build. A self explanotry basic CLI opens. No data is persisted between requests.

## Features
* Takes initial configuration data from JSON file
* Code structured between
	* models (contains schemas)
	* services (performs operations on this data) 
	* helpers (reads/writes data from json/console)
* Added a test case project as well and added test cases.
* Added basic validations for values out of range for enums, very basic name validations.

## Things to improve

* More test coverage (both unit and integration test)
* Better scheduling algorithms (The current one is brute force)
* Better validations for names
* Make a int unique key for doctors/patients etc.

