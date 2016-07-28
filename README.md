# Geni Protein Game

This project is a prototype for a Protein Game, built using
[Unity3d](http://unity3d.com) to simulate melanin distribution in the
epidermis of a drake.

In this demo, the melanosome (which is the packet of melanin) is being
transported along a highway in the cell. The purple motor proteins are
moving the melanosomes away from the nucleus and the yellow ones move it
closer. Depending on how many of each motor you have, the melanin spreads
out or not. In this game, students will have to attach motors to the
melanosome to either make it move to the right… (farther from nucleus) or
to the left (closer to the nucleus).

### Development Setup

Download the [latest edition of the Unity editor](http://store.unity3d.com)
and clone the project to your local machine. To open the project, point Unity
to this folder (there is no single file, Unity looks for the Assets folder to
determine whether the project can be opened.)

Running this project in the editor should highlight any issues. Building can
either be done locally (depending on installed modules) or via the
[Unity Cloud Build](https://build.cloud.unity3d.com/orgs/concord-consortium/projects/geni-protein-game/)
using the appropriate account.

### Recommended Development Tools

MonoDevelop is included as part of the Unity installation and does a reasonable
job, though Windows developers will have the best experience using
[Visual Studio Community](https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx)
It should be noted that despite all efforts to the contrary, you will end up
with line ending differenes between Windows and Mac. This discrepency is minor
when you discover the joy of live debugging with Visual Studio.

An alternative editor that is for both Mac and PC is [Visual Studio Code](https://code.visualstudio.com)
which can be configured to do a nice level of integration with Unity. Since
VSCode updates and changes quite frequently, you should check for current
instructions on setup if you want to use VSCode.

