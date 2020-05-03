# Model Update View

Model Update View (MUV) is an architecture well suited for functional programming.
It is also known as Elm architecture, named after the [Elm language](http://elm-lang.org/).
[Fable](http://fable.io/) is a very popular F# to JS compiler. On top, there's [Elmish](https://fable-elmish.github.io/elmish/), an extension that brings MUV to F#.
For the view part, there's [Elmish-React](https://fable-elmish.github.io/react/), using [React](https://facebook.github.io/react/) to render HTML.
A MUV program in its simplest form consists of a model, an update function returning a new model and a view rendering function.
The MUV architecture is becoming increasingly popular in latest (web) frameworks and applied in e.g. React and Vue.js

## TODO

In `src` and each sub-folder (except `Navbar`) there's a `X - TODO.md` file detailing the tasks at hand. Start with `0 - TODO.md`.

## Building and running the app

* Install JS dependencies: `yarn install`
* Start Fable daemon and [Webpack](https://webpack.js.org/) dev server: `yarn start`
* Open [your browser](http://localhost:8080/)

Any modification you do to the F# code will be reflected in the web page after saving. Watch the console for error messages.
