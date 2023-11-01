# Poker Charidema

Poker Charidema is a Poker simulator I'm creating as a excercise in Domain-Driven Design and SOLID design principles. Not everything I do will be good examples of the aforementioned, but I intend to learn and refactor as I go.

There are surely already Poker games built in .NET, better than the one I'm making. I'm purposely avoiding looking for or at any of those Poker implementations, because my primary goal is to learn and practice -- not to deliver a product.

I like the idea of eventually making this into a web application, but I could very well lose interest first.

_Charidema_ is a species of moth. It has nothing to do with poker. I picked it only so that this repository would have a distinctive name.

## Guidelines for Messaging Classes

The application makes extensive use of messaging classes. These are immutable value objects that represent a message that is passed between classes. These are separate from models, since they are only used for "plumbing", and don't represent domain objects.

As I've been using messaging classes, I've thought of some guidelines that helps them be used the correct way. My use of them in this application doesn't always follow these guidelines, but I intent to refactor as I go.

* Immutable.
* Should not contain any logic.
    * If we want any behavior, we should use an extension method or something else. 
* No dependencies.
* All properties are required.

### Request Guidelines

* Only include properties that will be used.
* If _only_ a parameter's sub-class will be used, then use that sub-class instead of the base class.

### Response Guidelines

* Only include properties that have been changed.
* The consumer is expected to use the response to update its state.