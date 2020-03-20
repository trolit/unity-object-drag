<h1>Unity Object Drag</h1>

<h2>Description</h2>

<p align="justify">Repository shows simple idea on how to implement object drag in Unity(especially for games that make use of top down view). I've decided to share it because when my project needed something similiar, most of the Web results concerned mouse Drag&Drop functionality. However I succeed to find tip with <em>gameObject.transform.parent</em>(Unity forum If I remember correctly). Making script to work flawlessly(without errors) took me some time but I think I got it. I used it for minigame puzzle. <a href="https://youtu.be/W4FGTbqTwsY">Here is the demo</a> showing object drag in practice. Template project for this repository was made in <strong>Unity 2019.3.3f1 (64-bit)</strong>. </p>

<h2>Content</h2>

<p align="justify">In the repo you will find scene used to show the results, Slime Rabbit character, and some scripts. For the purpose of repo I extended drag with ability to rotate moved objects. It's used by <em>DragHandler</em> and rotation is handled by script named <em>RotationHandler</em>. Script containing only drag functionality is called <em>raw_DragHandler</em>. There is also short description on how to use it properly. If you plan to use the option with rotation, <em>Movement Handler</em> has bool variable that you see on the picture below called <em>Dont Inherit Facing Direction</em>.</p>

<br/>
<br/>
<br/>

<p align="center"><img src="https://github.com/trolit/unity-object-drag/blob/images/images/inspectorScreenshot.PNG" width="500" alt="Unity Inspector fragment"></p>

<br/>
<br/>
<br/>

<p align="justify">What it means is that you can decide whether you want dragged objects to be positioned in front of the character when changing direction(inherit facing) or not(don't inherit facing). See the difference underneath:</p>

<br/>
<br/>
<br/>

| Don't Inherit Facing | Inherit Facing |
| :---: | :---: |
| <img src="https://github.com/trolit/unity-object-drag/blob/images/images/dontInheritFacing.gif" alt="Don't Inherit Facing example" width="500" /> | <img src="https://github.com/trolit/unity-object-drag/blob/images/images/inheritFacing.gif" alt="Inherit Facing example" width="500" /> |

<br/>
<br/>
<br/>

<p align="justify">When looking at example with inherit facing, you probably noticed problem that the text also reacts on changing direction. To solve this for e.g. you can place on the draggable object script called <em>LockRotation</em>. See the result.</p>

<br/>
<br/>
<br/>

<p align="center"><img src="https://github.com/trolit/unity-object-drag/blob/images/images/lockTextRotation.gif" width="500" alt="Gif showing blocked text rotation"></p>

<br/>
<br/>
<br/>

<p align="justify">I've also mentioned rotation possiblity. If you take a look again at the first image showing Unity inspector fragment, notice that <em>DragHandler</em> script also comes with bool variable. This one let's you turn on and off rotation on dragged objects. If you keep variable checked, you will be able to rotate dragged object by using <em>Left</em> and <em>Right</em> arrow key. As before, check the outcome below. </p>

<br/>
<br/>
<br/>

<p align="center"><img src="https://github.com/trolit/unity-object-drag/blob/images/images/rotatingObject.gif"  width="500" alt="Gif showing dragged object rotation"></p>

<h2>References</h2>

- Slime Rabbit character: <a href="https://assetstore.unity.com/packages/3d/characters/slime-rabbit-144436">link</a>
- Top down camera view: <a href="https://www.youtube.com/watch?v=5djfhgQkrk0">link</a>

<br/>
<br/>

Template generated using <a href="https://github.com/trolit/EzGitDoc">EzGitDoc</a>
