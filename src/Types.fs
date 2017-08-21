module App.Types

open Global

type Msg =
| CounterMsg of Counter.Types.Msg
| TodoMsg of Todo.Types.Msg
| HomeMsg of Home.Types.Msg

type Model = {
  currentPage: Page
  counter: Counter.Types.Model
  home: Home.Types.Model
  todo: Todo.Types.Model
}