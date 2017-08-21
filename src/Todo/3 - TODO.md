# TODO list

- [ ] Add a new message type `Add`. Note that this message needs no payload.  
      Following the compiler warnings, implement adding a new todo item.
- [ ] Add a new message type `Remove`. What payload does this discriminated union case need?
    - [ ] add a field to the model, keeping track of the next id
    - [ ] Following the compiler warnings, implement removing a todo item.
- [ ] *Bonus* Extend the model with a clickable `Done` flag (render using e.g. `fa-square-o` and `fa-check-square-o`)  
      When clicking the button, toggle the done state.