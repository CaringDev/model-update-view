# Model Update View

Model Update View (MUV) is an architecture well suited for functional programming.  
It is also known as Elm architecture, named after the [Elm language](http://elm-lang.org/).
[Fable](http://fable.io/) is a very popular F# to JS compiler. On top, there's [Elmish](https://fable-elmish.github.io/elmish/), an extension that brings MUV to F#. For the view part, there's [Elmish-React](https://fable-elmish.github.io/react/), using [React](https://facebook.github.io/react/) to render HTML.  
A MUV program in its simplest form consists of a model, an update function returning a new model and a view rendering function.  
The MUV architecture is becoming increasingly popular in latest (web) frameworks and applied in e.g. React and Vue.js

## TODO

In `src` and each sub-folder (except `Navbar`) there's a `X - TODO.md` file detailing the tasks at hand. Start with `0 - TODO.md`.

## Building and running the app

* Install JS dependencies: `yarn install`
* Move to `src` folder: `cd src`
* Install F# dependencies: `dotnet restore`
* Start Fable daemon and [Webpack](https://webpack.js.org/) dev server: `dotnet fable yarn-start`
* In your browser, open: http://localhost:8080/

> `dotnet fable yarn-start` is used to start the Fable daemon and run a script in package.json concurrently. It's a shortcut of `yarn-run [SCRIP_NAME]`, e.g. `dotnet fable yarn-run start`.

If you are using VS Code + [Ionide](http://ionide.io/), you can also use the key combination: Ctrl+Shift+B (Cmd+Shift+B on macOS) instead of typing the `dotnet fable yarn-start` command. This also has the advantage that Fable-specific errors will be highlighted in the editor along with other F# errors.

Any modification you do to the F# code will be reflected in the web page after saving. When you want to output the JS code to disk, run `dotnet fable yarn-build` and you'll get a minified JS bundle in the `public` folder.