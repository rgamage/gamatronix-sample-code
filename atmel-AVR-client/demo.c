/*
Demo app to demonstrate control of a Gamoto, using the Gamoto Object class
Written by Randy Gamage, Gamatronix, 2006

*/
#include "gamoto.h"

#include <iostream>
using namespace std;

int main() {

	Gamoto myG;
    myG.Init(1,19200,0);  //intialize Gamoto with COM port number, baud rate, and device id
	int Ver = myG.getVersion();

/*
	//Alternative style using pointers
    Gamoto* myG = new Gamoto();
    myG->Init(1,19200,0); //intialize Gamoto with COM port number, baud rate, and device id
	int Ver = myG->getVersion();
*/

	cout << "Firmware version = " << Ver << endl;
	
	//Set P,I,D parameters - change these for your motor/system
	myG.setKp(500);
	myG.setKi(3);
	myG.setKd(200);

	//Demonstrate Position Mode
	cout << "Moving to +10000 in Position mode..." << endl;
	myG.setMode(POSITION_MODE);
	myG.setsetPosition(10000);
	//wait until we get to 10000
	while (myG.getmPosition()!=10000);
	cout << "Moving back to zero in position mode..." << endl;
	//set setPosition to 0
	myG.setsetPosition(0);
	//wait until we get to 0
	while (myG.getmPosition()!=0);

	//Demonstrate Velocity Mode
	cout << "Moving to +10000 in Velocity mode..." << endl;
	myG.setMode(VELOCITY_MODE);
	myG.setsetVelocity(2000);
	//wait until we reach 10000 (will probably overshoot it, because we are in velocity mode)
	while (myG.getmPosition()<10000);
	myG.setsetVelocity(0);
	cout << "Returning to 0 in Velocity mode..." << endl;
	myG.setsetVelocity(-2000);
	while (myG.getmPosition()>0);
	myG.setsetVelocity(0);

	//Demonstrate Trajectory Mode
	cout << "Moving to +10000 in Trajectory mode..." << endl;
	myG.SetHome();          //zero out set and actual positions
	myG.setTrajx(10000,0);	//set distance (x) for trajectory #0
	myG.setTrajv(5000,0);	//set velocity for traj #0
	myG.setTraja(10,0);		//set accel for traj #0
	myG.setTrajectory(0);	//select trajectory #0 - not needed unless you are using multiple trajectories
	myG.setMode(TRAJECTORY_MODE); // GO !!
	while (myG.getMode()==TRAJECTORY_MODE);  //wait for traj to finish
	cout << "Moving to 0 in Trajectory mode..." << endl;
	myG.setTrajx(-10000,0);  //set distance for traj#0 (distances are relative for trajectories)
	myG.setMode(TRAJECTORY_MODE); // GO !!
	while (myG.getMode()==TRAJECTORY_MODE);  //wait for traj to finish

	//
	cout << "Done!" << endl;

	system("PAUSE");
	return 0;
}
