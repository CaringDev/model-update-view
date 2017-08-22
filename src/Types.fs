module App.Types

open Global

type Msg =
| HomeMsg of Home.Types.Msg
| CounterMsg of Counter.Types.Msg
| TodoMsg of Todo.Types.Msg
| DrawMsg of Draw.Types.Msg

type Model = {
  currentPage: Page
  home: Home.Types.Model
  counter: Counter.Types.Model
  todo: Todo.Types.Model
  draw: Draw.Types.Model
}