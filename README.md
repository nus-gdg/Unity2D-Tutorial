# Unity2D-Tutorial

Welcome to Part 1 of GDG's Unity 2D-Tutorial! This little .txt is 
here in case you missed the session, or forget what the point of 
each of these scenes is.

# Introduction
In Unity, the elements of a game are arranged in a Scene.
These elements are in turn called GameObjects.
The behaviour of GameObjects is specified by their Components.

In each of these Scenes, we aim to show you a few basic Components
that can get you started with working in Unity.

# Scene 1 - Sprite Renderers
A Sprite Renderer, is as its name suggests, a Component that tells
Unity to render a Sprite where the GameObject is.

In this Scene, The Sprite Renderer has been Disabled. Click on the
GameObject "Unity-Chan" in the Hierarchy in order to bring up the
same object in the Inspector.

Now, click on the checkbox beside the "Sprite Renderer" name. This
should make the sprite appear on-screen.

As you can see, there are many options under the Sprite Renderer
component in the Inspector. Feel free to experiment with them.
For now, see how click the checkboxes for flipping in the X or Y
dimension will cause the sprite to be flipped.

# Scene 2 - Box Colliders
Box Colliders specify a solid object in space. In this Scene, both
the "Unity-Chan" GameObject and the "No" GameObject have a 
Box Collider 2D Component on them.

Look for the Play button at the top of the program and click on it.
This will cause the current Scene to play. After waiting a while, 
you should see "Unity-Chan" fall down and land on the 
"No" GameObject.

Now, try to disable the Box Collider 2D Components on either of the
two objects. This can be done whether or not the program is in Play
mode. You should see that "Unity-Chan" now falls through the "No"
GameObject.

# Scene 3 - Rigidbodies
Rigidbodies are Components that tell the Unity Engine to simulate
the Physics of a GameObject.

In this Scene, the two "Unity-Chan" GameObjects have a Script
attached that allows you to move them in Play mode.

The default controls are as follows:
D     - Right
A     - Left
Space - Jump

Similar capabilities are useful for a multitude of games, such as
platformers, that require you to run and jump.

# Scene 4 - Trigger Colliders
Trigger Colliders are similar to Box Colliders in that they allow
GameObjects on-screen to interact.

Here, the "TriggerArea" GameObject will turn green when "Unity-Chan" 
touches it, and turn back to red once she stops.

This is useful for situtations such as triggering an event when a 
Character steps into a particular region on-screen.

# Scene 5 - Scripts and Prefabs
Of all the Components in Unity, the one that offers the flexibility
are Scripts. These allow you to communicate directly with Components
through your own code and thus affect the Game in more ways that
simply attaching Components can help you achieve.

Prefabs allow us to save and duplicate GameObjects for repeated use. 
This is useful for example in order to create bullets, or when we
want to spawn enemies repeatedly.

This scene is currently incomplete, and we will do a few things to
make it closer to a real game.

1. Adding your own script

Right now, the player doesn't really do anything. It just stands there,
lifeless.

Let's change it so that we can take control of it!

- Movement control script

We want to make it fire too!

Shooting control script

2. Completing fields in Scripts
If you look at "Stubby" in the Inspector, you should see that he has
two Scripts attached, "Movement Control" and "Shooting Control".
Right now, the "Bullet" field in Stubby's "Shooting Control" Script
is empty.

The "Shooting Control" Script is used to give "Stubby" the 
capability to fire bullets when we click the screen. If we attempt
to do this right now with an empty "Bullet" field, we will get an 
error. Let's rectify this. Open the "Project" window and look for
the Prefabs  folder. Now drag the "Pellet" Prefab into the "Bullet"
field.

Now, if we start the game, we will see that a "Pellet" will be
cloned and fired from "Stubby" towards the direction of the our
left click.

3. Facing the mouse

But isn't it weird that Stubby keeps pointing upwards? We should
make it always face the mouse cursor instead

- Face Mouse script

4. Enemies

By now, you might have noticed the "Jeff" GameObject that does
nothing while sitting on the Screen. Jeff is intended to be an enemy,
so let's make it one!

Attach the enemy script to Jeff.

It's not working! Even when bullets hit Jeff, nothing happens!

Why do you think this is the case? Hint: Scene2 Tutorial

Let's add an appropriate Collider to Jeff. Now, let's run the game and...
what's going on? It's like Jeff has some sort of shield preventing the
bullets from touching him.

Why? Hint: Scene4 Tutorial

Now let's make it a trigger. Now, we can see that it's working and that
Jeff will die after 3 hits.

But wait! Sometimes, when the bullets haven't hit Jeff yet, or look like they
will miss, Jeff still takes damage or dies! We should fix this by reducing
the collider.

5. Attaching Scripts
We want to make "Jeff" follow the Player around.

In order to do this, let's attach a Script to "Jeff" that specifies
this behaviour. Luckily, such a Script already exists. Click on
"Jeff" to bring him up in the Inspector. Now, either:
A) Click "Add Component" and type in "Follow". This will search
   for the "Follow Object" Component in our Project. Press enter, and
   the "Follow Object" Component should have been added to "Jeff".
B) Open the "Project" window and open the "Scripts" folder. There
   should be a Script titled "Follow Object". Drag this onto "Jeff" in
   the Inspector window.

We need to choose who to follow, so let's set the Object To Follow to 
Stubby

Now, if we Play the Scene, "Jeff" should have begun following
"Stubby" around.

 
6. Creating our own Prefabs
Imagine, that rather than having a single "Jeff" follow "Stubby"
around, we can have multiple "Jeff"s on-screen doing the same thing.
Now, we'll try to make an "EnemySpawner" object to accomplish this.

Right-click on the Hierarchy, and choose "Create Empty". This time,
add the "EnemySpawner" Script to the new GameObject. This Script
should have one empty field, "Enemy To Spawn". For now, drag "Jeff"
into this field.

If we start the game, we will see that if we kill the original
"Jeff", no more "Jeff"s will spawn in the game. This is because the
"EnemySpawner" holds a reference to the original "Jeff". In order to
get around this, let's attached a Prefab generated from "Jeff" into
the same field instead.

Now, outside of Play mode, open the "Prefabs" folder. Drag "Jeff"
from the Scene view into the "Prefabs" folder. Congratulations,
you've just created your own Prefab. Now, drag this Prefab of "Jeff"
onto the "Enemy To Spawn" field of our "EnemySpawner" Script from
before.

Now, the game will proceed indefinitely, and new "Jeff"s can be
endlessly spawned.

7. (If time allows) Particle system

We can add a particle system to the main character so that an effect
will play whenever we shoot!

GameObject -> Effects -> Particle System

Handle rotation in 3D space

Make it a child object of the player

Set to world co-ordinates

Attach to script

# Bye

That's it for now! Next time, we will be talking about how to write
your own Scripts.

For now, feel free to play around with the Scenes in this tutorial,
or if you're up for, start working on your own projects! If there's
anything you don't understand about Unity, or if there's anything 
you want to try to create, feel free to ask on the Discord =w=.

# Credits

This tutorial was made by:
National University of Singapore
Games Development Group