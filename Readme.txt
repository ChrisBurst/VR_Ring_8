This work is licensed under the Creative Commons Attribution 4.0 International License. To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/ or send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.

If you use this work, or any adaptation, in an academic work, cite as follows:

Sawyer, B.D., Burst, C. (2015). VR Ring 1.0 [Computer software]. Orlando, FL.

---------------

This project places the participant, wearing an Oculus Rift and headphones, in the center of a ring or sphere of lights. The lights will turn on and play a sound, and the participant will search for them. The order the lights turn on will be determined by an input file, and the time it takes for the participant to find a light and press any key while looking at it will be recorded to an output file.

Three versions of the project exist currently; a 8-dot ring, a 20-dot dodecahedron, and a 60-dot soccer ball shape. Aside from the number and shape they function similarly.
They accept input from the file “input.csv” and will create files to store data called “output.csv”
The input files are just a row of numbers. The simulation (sim) will find the light that matches that number and light it up. When the participant finds that light then the next one on the list will light up. I cannot say which number goes to which light as the arrangements are systematically generated. That said, they are not random. The same input file should light up the same lights in any run.
If the input file contains numbers greater than the number of lights, it will be subtracted by the total number of lights until it fits within the range.
The output file will record data every time a light turns on or a participant finds a light. It will record the time since the test started, the action that occurred, and how long it took the participant to find each light. Output files will assign themselves numbers to avoid accidentally overwriting themselves. They will always give themselves the lowest possible number that doesn’t already exist in the file the sim’s executable is in. 
Press Escape to quit the sim at any time.
