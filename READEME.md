# Poker Charidema

Poker Charidema is a Poker simulator I'm creating as a excercise in Domain-Driven Design and SOLID design principles. Not everything I do will be good examples of the aforementioned, but I intend to learn and refactor as I go.

There are surely already Poker games built in .NET, better than the one I'm making. I'm purposely avoiding looking for or at any of those Poker implementations, because my primary goal is to learn and practice -- not to deliver a product.

I like the idea of eventually making this into a web application, but I could very well lose interest first.

_Charidema_ is a species of moth. It has nothing to do with poker. I picked it only so that this repository would have a distinctive name.

## Projects

### Poker.Presentation.Interface

Abstractions of presentation elements.

The user interface is abstracted through _preference services_, so why is this needed?

Messages that the domain service sends to the UI have different levels of importance and emphasis (e.g. "Joe wins the match!" vs. "Joe draws 2 cards"), which can be presented differently. This abstraction should give the domain services the ability to convey importance and emphasis without being tempted to control presentation (e.g. adding newline characters, using all caps, etc.).

One way to abstract this even further would be through a service that would tranlate objects representing poker events (i.e. any single thing that happens in a Poker match) to human language. That would require a series of _poker event_ classes rich enough to contain those details. I'll leave that for a future refactor. 
