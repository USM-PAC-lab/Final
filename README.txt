BEFORE OPENING THE PROJECT MAKE SURE YOU ARE RUNING UNITY VERSION 2018.2.20f1 OR BELOW.

When starting the experiment begin on the "setup" scene. (Go to Assets -> Scenes -> Setup)

Click the Play button to start the experiment.
Click Variables button on the screen. Enter Participant#, eyeheight (m), Arm length (m), Shoulder Height (m), handedness.
Press the Back button.
Press CTRL+SHIFT+R to start the experiment.

Scenes: 





Scripts: 
ClickerTicker- This records an error whenever the Z key is pressed down. It also recenters the participant in the environment when the R key is pressed down.

Level2- This script controls how many scenes are in each block and is responsible for randomly choosing the next scene after each trial. 

mover- This script should be attached to the stimulus and is responsible for placing that stimulus in relation to the participants arm length.

Order- Is refrenced by the ResponseTime script to record the order of positions the participant would stand in.

PositionData- Records Data about what trial the participant is in with relation to the position and rotation of the headset.

ResponseTime- records the current scene, the yes or no response, and other relevent information. It is also responsible for controlling how many blocks of trials are presented.

Variables- contains the data entered at the setup screen