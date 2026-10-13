# in-class-activities
## Devlogs
### W1
Moving the camera off the "cat" game object causes the cat to move without the camera following. This is because the camera component is no longer synced with the Cat game object, causing the
player code file to no longer apply to the camera, and thus creates this issue where the cat will run off without you following when using WASD.

Itch page: https://popotsai.itch.io/w1-in-class-activity-cat-movement

### W2
1) The variables r, g, and b are floats because these values need to contain decimals for their precise color variation, while also being a number. This prevents strings and bools from being used as neither text nor "true/false" operators match this, and int are also too limited into whole numbers, while the r, g, b color scale still need to be changed by decimal point.
2) The variable _bounce is set as an int, since we are counting the number of bounces, making booleans unnecessary. While strings are possible, it is easier to utilize arithmetic operations with either ints or floats instead. And as for why they don't use floats, it's simply because bounces are always going to be a whole number, making ints more efficient and easier.
3) The error I was told, was that you can't implicitly convert doubles into floats, which tells us that the operator "g -= 0.1;" was missing something that caused g to no longer be subtracted by another float. Therefore, since I know that g is a float, I can tell that 0.1 was not, and I needed to add an f to make "g -= 0.1f;" instead so that the operator worked between 2 floats, and would work properly.

### W3
Activity 1: Table 4
    1) We believe the parameters would likely be the friendship level as most likely an int, double, or float; as well as the flag as a bool for true/false on knowing the character's secret.
    Then the return type would just be one of multiple string character response to the player.
    2) We said the parameters would be the sanity level as an int from 0-100%.
    And since the question mentioned not needing an output, there would be no return.
    3) We thought the parameters would likely be maybe an int on when the player was supposed to hit the beat, and another int for when the player did hit the beat.
    So then the return type can be either a bool on true/false if they hit the beat on time, or another type like int that can count how well the player timed it.

Activity 2: Table 4
    We chose to compare a method to an ingredient on a taco, that can be prepared in any way you want through the member variables as spices or flavorings for your method topping. This one topping can be many ingredients, like ground beef, lettuce, cheese, etc. but all have a purpose. Then once prepared and cooked by the member variables, it will then be put onto a tortilla
    which would be the equivalent to setting up a class, able to hold many other ingredients/methods that define what the finished class would be. You then take the fully prepared taco/class that can function for many things based on the ingredients/methods inside it, for instance a beef taco being a component, or whatever else you may want. The taco class can then be plated
    for your game to be used in the scene and function however you want it to.

Activity 3:
    The ball appears to get extremely bright to the point of becoming white the faster they move, because of how color works. Since we know the value for white is color(1, 1, 1), meaning as
    long as the original set rgb values for color are greater than 0, then they will continuously multiply. And as they bounce, the multiplier continues to increase each r, g, and b value
    until reaching the cap of 1, causing all the balls to appear extremely bright as they bounce multiple times at faster and faster speeds.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 