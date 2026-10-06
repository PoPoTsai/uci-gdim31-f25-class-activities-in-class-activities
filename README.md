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

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 