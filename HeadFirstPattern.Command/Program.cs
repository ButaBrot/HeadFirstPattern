
using HeadFirstPattern.Command;
using HeadFirstPattern.Command.Commands;
using HeadFirstPattern.Command.FremdApis;

var light = new Light();
var garage = new GarageDoor();
var stereo=new Stereo();

var lightOnCommand = new LightOnCommand(light);
var lightOffCommand = new LightOffCommand(light);
var garageOpenCommand = new GarageDoorOpenCommand(garage);
var garageCloseCommand = new GarageDoorCloseCommand(garage);
var stereoSetCDCommand = new StereoSetCDCommand(stereo);
var stereoOffCommand = new StereoOffCommand(stereo);

var remoteController = new RemoteController();

remoteController.SetController(0, lightOnCommand, lightOffCommand);
remoteController.SetController(1, garageOpenCommand, garageCloseCommand);
remoteController.SetController(2, stereoSetCDCommand,stereoOffCommand);
remoteController.SetController(2, ()=>light.On(),stereoOffCommand);

remoteController.OnButtenWasPushed(0);
remoteController.OnButtenWasPushed(1);
remoteController.OnButtenWasPushed(2);
Console.WriteLine(new String('-',30));
Console.WriteLine(remoteController.ToString());
Console.WriteLine(new String('-',30));
remoteController.OffButtenWasPushed(0);
remoteController.OffButtenWasPushed(1);
remoteController.OffButtenWasPushed(2);