module Draw.Types

type Coordinate = { x: float; y: float }
type Rect = { x: float; y: float; width: float; height: float }
type Model = { elements: Rect list; startCoordinate: Coordinate option }

type Msg =
| Adding of Coordinate