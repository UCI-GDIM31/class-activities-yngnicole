# in-class-activities
## Devlogs

### W1
Hello world!

### W2
The r, g, and b variables are floats because the value of color can vary and won't always be a perfect whole number. 
The _bounce variable is an int because you can't bounce half a time, you can only bounce one whole time or two whole time, etc. 
The line of code was broken because there wasn't a ; after the code.

### W3
My table number is 4. We talked about how the parameter would be a float because the input is based on the time they hit the key. 
The return type would be a bolean because it is trying to see if the player hit the beat or not.
The metaphor for a class and component is that a class is a intruction manual to a component and a component is whatever you are trying to build. A member variable is each part of the build, and method is what the build is used for. For example if we are building a chair, the class would be an intruction manual on how to build the chair. The component would be the chair itself. the member variable would be the parts of a chair like the legs and the method is that the chair is used for sitting. 

### W4
We are table 1: Describe lines 5, 22, and 25
Line 5 is a member variable in the class CW4 with the type float.
Line 22 is method that is calling the arguememt "Vertical." The type is a float. It moves the object vertically because it is being called vertically. The vertical movement is multiplied by speed and time. 
Line 25 is declaring the variable Translate. The parameters of Translate are 0, 0 and translation.
Our solution we came up with for the collider activity is to put a Rigidbodies to the Cat and the Soccer Ball so that they can move and come into contact with objects. 
We checked Is Trigger for the Goal so that the ball can go through the goal. 
Our game didn't work perfectly the first time because our cat and ball were rotating everywhere. To fix this we set constraints to the cat and froze the rotation. The ball was being kicked everywhere and rotating because the Cat's collider was on the ball inside of on the cat. We fixed the collider onto the cat and changed to shape to match the cat. 