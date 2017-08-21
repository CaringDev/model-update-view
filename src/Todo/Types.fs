module Todo.Types

open System

type Todo = { Id: int; Text: string }
type Model = { Input: string; Items: Todo list }

type Msg =
| InputChanged of string