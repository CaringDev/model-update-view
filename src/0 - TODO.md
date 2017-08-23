# Debugging

Debugging MUV (Flux, Redux, ...) applications is easy:

- [ ] install Redux DevTools in Chrome or Firefox, comment out `|> Program.withDebugger` in `App.fs`.
- [ ] when done, let me know... I'll give a short demo.

## Bonus
Tackle this after all other TODOs... don't even bother reading before.

- [ ] *all, easy* Create a (functional) means of saving and loading state after update respectively init.
- [ ] *draw, hard* How can we further (beyond React Shadow DOM) optimize the drawing of many shapes?  
    Hint: we might need to give up some purity in favor of keeping state locally.  
    Hint: lower abstraction might give us better performance (SVG vs. canvas)