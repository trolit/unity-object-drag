<h1>Unity Object Drag</h1>

<h2>Description</h2>

<p align="justify">Repository shows simple idea on how to implement object drag(especially for games that make use of top down view). I've decided to share it because when my project needed something similiar, most of the Web results concerned mouse Drag&Drop functionality. However I succeed to find tip with <em>gameObject.transform.parent</em>. Making script to work flawlessly(without errors) took some time but I think I got it. I used it for minigame puzzle. <a href="https://youtu.be/W4FGTbqTwsY">Here is demo</a> showing object drag in practice. </p>

<h2>Content</h2>

<p align="justify">In the repo you will find scene used to show the results, Slime Rabbit character, and some scripts. For the purpose of repo I extended drag with ability to rotate moved objects. It's used by DragHandler and rotation is handled by script named <em>RotationHandler</em>. Script containing only drag functionality is called <em>raw_DragHandler</em>. If you plan to use the option with rotation, <em>Movement Handler</em> has bool variable that you see on the picture below called <em>Dont Inherit Facing Direction</em>.</p>

<p align="center"><img src="https://github.com/trolit/unity-object-drag/blob/images/images/inspectorScreenshot.PNG" width="500" alt="Unity Inspector"></p>

<p align="justify">What it means is that you can decide whether you want dragged objects to be positioned in front of the character when changing direction(inherit facing) or not(dont inherit facing). See the difference underneath:</p>

| Dont Inherit Facing | Inherit Facing |
| :---: | :---: |
| <img src="https://github.com/trolit/unity-object-drag/blob/images/images/dontInheritFacing.gif" alt="#toadd" width="500" /> | <img src="https://github.com/trolit/unity-object-drag/blob/images/images/inheritFacing.gif" alt="#toadd" width="500" /> |

<p align="justify">When looking at example with inherit facing you probably noticed problem that the text also react on changing direction. To solve this for e.g. you can place on the object that will be dragged script called <em>LockRotation</em></p>. See the result.

<p align="center"><img src="https://github.com/trolit/unity-object-drag/blob/images/images/lockTextRotation.gif" width="500" alt="Gif showing blocked text rotation"></p>

<p align="justify">But I've also mentioned rotation possiblity. If you take a look again at the first image showing Unity inspector fragment, notice that DragHandler script has also bool variable. This one let you turn on and off rotation on dragged objects. If you keep variable checked, you will be able to rotate dragged object by using Left and Right arrow key. As before, check the outcome below. </p>

<p align="center"><img src="https://github.com/trolit/unity-object-drag/blob/images/images/rotatingObject.gif"  width="500" alt="Gif showing dragged object rotation"></p>

<h2>References</h2>

- Slime Rabbit character: <a href="https://assetstore.unity.com/packages/3d/characters/slime-rabbit-144436">link</a>
- Top down camera view: <a href="https://www.youtube.com/watch?v=5djfhgQkrk0">link</a>

<br/>
<br/>

Template generated using <a href="https://github.com/trolit/EzGitDoc">EzGitDoc</a>
