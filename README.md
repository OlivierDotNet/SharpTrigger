## Introduction -- SharpTrigger
SharpTrigger is a Class Library that allows you to Fire &amp; Forget methods!

It's **THAT** simple!

>![image](https://user-images.githubusercontent.com/92113985/181773494-797ac38b-4c58-42ea-a4f3-6dc2714776ee.png)
>![image](https://user-images.githubusercontent.com/92113985/181773827-c0cbac72-5ac0-40d5-a0f9-1a95b9cf3e00.png)	

Or just use it like any other delegate!
>![image](https://user-images.githubusercontent.com/92113985/181777290-bb92a5d5-35ad-4884-b8f1-71b04f7fdc5a.png)


## Usage 
#### Properties
`Trigger`.`HasDelegate` -- returns whether the Trigger has a Delegate <br>
`Trigger`.`HasFured` -- returns whether the Trigger has Fired <br>

#### Methods
`Trigger`.`Fire()` -- Fires the Trigger <br>
`Trigger`.`Reload()` -- Reloads the Trigger, allowing for subsequent firing <br>

#### Initialization
Creation of Trigger
`Trigger trigger = new Action()` <br>
Trigger to Action conversion
`Action act = trigger` <br>

## Installation

[Get the latest .DLL Release](https://github.com/OlivierORRataj/SharpTrigger/releases), then (preferably but optionally) drag and drop the .DLL file into your project directory, thereafter add it as a Project Reference. An .XML file is included in each release, it contains comments for every base class member.
