module Global

type Page =
  | Home
  | Counter
  | Todo

let toHash page =
  match page with
  | Home -> "#home"
  | Counter -> "#counter"
  | Todo -> "#todo"