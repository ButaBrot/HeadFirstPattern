
using HeadFirstPattern.Command;
using HeadFirstPattern.Command.Commands;
using HeadFirstPattern.Command.FremdApis;

var light = new Light();
var garage = new GarageDoor();
var lightCommand = new LightOnCommand(light);
var garageCommand = new GarageDoorOpenCommand(garage);
var remoteControl = new SimpleRemoteControl(lightCommand);

remoteControl.ButtonWasPressed();
remoteControl.SetSlot(garageCommand);
remoteControl.ButtonWasPressed();