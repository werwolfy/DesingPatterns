using Command;
using Command.Commands;

var light   = new Light();           // Receiver
var remote  = new RemoteControl();   // Invoker

var turnOn  = new TurnOnCommand(light);
var turnOff = new TurnOffCommand(light);

remote.Press(turnOn);
remote.Press(turnOff);  
remote.PressUndo();     
remote.PressUndo();