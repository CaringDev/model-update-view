module Draw.State

open Types

let init () =
    { elements = [ { x = 10.; y = 20.; width = 100.; height = 50. } ]; startCoordinate = None }, []

let update msg model =
    match msg with
    | Adding pos ->
        { model with startCoordinate = Some pos }, []