<h1>Unity Object Drag</h1>

<h2>Description</h2>

<p align="justify">Repository shows simple idea on how to implement object drag(especially for games that make use of top down view). I've decided to share it because when my project needed something similiar, most of the Web results concerned mouse Drag&Drop functionality. However I succeed to find tip with <em>gameObject.transform.parent</em>. Making script to work flawlessly(without errors) took some time but I think I got it. I used it for minigame puzzle. <a href="https://youtu.be/W4FGTbqTwsY">Here is demo</a> showing object drag in practice. </p>

<h2>Content</h2>

<p align="justify">In the repo you will find scene used to show the results, Slime Rabbit character, and some scripts. For the purpose of repo I extended drag with ability to rotate moved objects. It's used by DragHandler and rotation is handled in RotationHandler script. Script containing only drag functionality is named raw_DragHandler.  </p>

| Dont Inherit Facing | Inherit Facing |
| :---: | :---: |
| <img src="https://github.com/trolit/unity-object-drag/blob/images/images/dontInheritFacing.gif" alt="#toadd" width="500" /> | <img src="https://github.com/trolit/unity-object-drag/blob/images/images/inheritFacing.gif" alt="#toadd" width="500" /> |

<p align="justify">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>

<p align="center"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/No_image_available.svg/1024px-No_image_available.svg.png" width="250" alt="Unity Inspector"></p>

<p align="justify">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>

<p align="center"><img src="https://github.com/trolit/unity-object-drag/blob/images/images/rotatingObject.gif"  width="500" alt="Gif showing dragged object rotation"></p>

<p align="justify">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>

<p align="center"><img src="https://github.com/trolit/unity-object-drag/blob/images/images/lockTextRotation.gif" width="500" alt="Gif showing blocked text rotation"></p>

<h2>Authors</h2>

Template generated using <a href="https://github.com/trolit/EzGitDoc">EzGitDoc</a>
