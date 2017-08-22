module Todo.Types

open System

type Todo = { id: int; text: string }
type Model = { input: string; items: Todo list }

type Msg =
| InputChanged of string