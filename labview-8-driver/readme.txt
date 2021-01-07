Gamatronix Gamoto LabView Library
===================================
This library was written with LabView 8.0.  No attempt has been made
try using it with LabView 7.x or earlier versions.

To use the library:

1) First, make sure you have installed the "NI-VISA" drivers / runtime.
To tell if you have it installed, run the Initialize.vi, and choose the 
If you can see a drop-down list of available COM ports, then VISA is probably
installed on your system.  If you don't see any options in the "VISA Resource
Name" drop-down, you may need to install the NI-VISA driver, from your LabView CD, or here:
http://digital.ni.com/softlib.nsf/webcategories/85256410006C055586256BBB002C0E91?OpenDocument&node=132060_US

2) Make sure the Gamoto is connected properly to your PC by running MotoView
and verifying communication.  Close MotoView.

3) Open the Initialize.vi and in the VISA Resource Name drop-down, choose the COM
 port that is connected to the Gamoto.  To save this as the default value, right-
 click on the control and choose "Data Operations", "Make this the default value",
 then save the .vi file.  This selection must be made on several of the .vi modules.

4) Run the Initialize.vi, and watch for a green check-box in the Error Out area.
If there is a red X, then there was a problem opening the connection. If there
is a green check box, then the firmware version of your board will be displayed
in the "Firmware Version" indicator.

A summary of the .vi files and their functions:

Close.vi - closes the serial port - called in the event of an error
Initialize.vi - Configures and opens the COM port and reads the firmware version of the Gamoto
ReadRegister.vi - basic register read function. Given register address and length, returns value
WriteRegister.vi - basic register write function.  Given register address and length, and data, writes data
Read_by_Name.vi - same as ReadRegister, but input is a register name from a drop-down list, no need to know address or length
Write_by_Name.vi - similar to Read_by_Name, but for Write operations
ChartData.vi - graphing example, to show how to create a running graph of any two Gamoto registers
WritePanel.vi - Utility panel to write to any register, to save settings, and an example of two slider controls
                to continuously write values to two registers.

Please give any feedback on this library to sales@gamatronix.com

