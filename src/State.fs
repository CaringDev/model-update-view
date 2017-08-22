module App.State

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Import.Browser
open Global
open Types

let pageParser: Parser<Page->Page,Page> =
  oneOf [
    map Counter (s "counter")
    map Home (s "home")
    map Todo (s "todo")
    map Draw (s "draw")
  ]

let urlUpdate (result: Option<Page>) model =
  match result with
  | None ->
    console.error("Error parsing url")
    model,Navigation.modifyUrl (toHash model.currentPage)
  | Some page ->
      { model with currentPage = page }, []

let init result =
  let (home, homeCmd) = Home.State.init()
  let (counter, counterCmd) = Counter.State.init()
  let (todo, todoCmd) = Todo.State.init()
  let (draw, drawCmd) = Draw.State.init()
  let (model, cmd) =
    urlUpdate result
      { currentPage = Home
        home = home
        counter = counter
        todo = todo
        draw = draw }
  model, Cmd.batch [ cmd
                     Cmd.map HomeMsg homeCmd
                     Cmd.map CounterMsg counterCmd
                     Cmd.map TodoMsg todoCmd
                     Cmd.map DrawMsg drawCmd ]

let update msg model =
  match msg with
  | HomeMsg msg ->
      let (home, homeCmd) = Home.State.update msg model.home
      { model with home = home }, Cmd.map HomeMsg homeCmd
  | CounterMsg msg ->
      let (counter, counterCmd) = Counter.State.update msg model.counter
      { model with counter = counter }, Cmd.map CounterMsg counterCmd
  | TodoMsg msg ->
    let (todo, todoCmd) = Todo.State.update msg model.todo
    { model with todo = todo }, Cmd.map TodoMsg todoCmd
  | DrawMsg msg ->
    let (draw, drawCmd) = Draw.State.update msg model.draw
    { model with draw = draw }, Cmd.map DrawMsg drawCmd