module App.View

open App.State
open Elmish
open Elmish.Navigation
open Elmish.UrlParser
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Global
open Types

importAll "../sass/main.sass"

let menuItem label page currentPage =
    li
      [ ]
      [ a
          [ classList [ "is-active", page = currentPage ]
            Href (toHash page) ]
          [ str label ] ]

let menu currentPage =
  aside
    [ ClassName "menu" ]
    [ p
        [ ClassName "menu-label" ]
        [ str "Menu" ]
      ul
        [ ClassName "menu-list" ]
        [ menuItem "Home" Home currentPage
          menuItem "Counter" Counter currentPage
          menuItem "Todo" Todo currentPage
          menuItem "Draw" Draw currentPage ] ]

let root model dispatch =

  let pageHtml =
    function
    | Home -> Home.View.render model.home (HomeMsg >> dispatch)
    | Counter -> Counter.View.render model.counter (CounterMsg >> dispatch)
    | Todo -> Todo.View.render model.todo (TodoMsg >> dispatch)
    | Draw -> Draw.View.render model.draw (DrawMsg >> dispatch)

  div
    []
    [ div
        [ ClassName "navbar-bg" ]
        [ div
            [ ClassName "container" ]
            [ Navbar.View.render ] ]
      div
        [ ClassName "section" ]
        [ div
            [ ClassName "container" ]
            [ div
                [ ClassName "columns" ]
                [ div
                    [ ClassName "column is-3" ]
                    [ menu model.currentPage ]
                  div
                    [ ClassName "column" ]
                    [ pageHtml model.currentPage ] ] ] ] ]

open Elmish.React
open Elmish.Debug

Program.mkProgram init update root
|> Program.toNavigable (parseHash pageParser) urlUpdate
|> Program.withReactBatched "app"
// |> Program.withDebugger
|> Program.run