
using HeadFirstPattern.Command;
using HeadFirstPattern.Command.Commands;
using HeadFirstPattern.Command.FremdApis;

var light = new Light();
var lightCommand = new LightOnCommand(light);
var remoteControl = new SimpleRemoteControl(lightCommand);

remoteControl.ButtonWasPressed();