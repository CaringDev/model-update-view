module Global

type Page =
| Home
| Counter
| Todo
| Draw

let toHash = function
| Home -> "#home"
| Counter -> "#counter"
| Todo -> "#todo"
| Draw -> "#draw"