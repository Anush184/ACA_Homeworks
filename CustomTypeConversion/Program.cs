using CustomTypeConversion;

//Coordinate point = null;
Coordinate point = new Coordinate(3.5, 7.2); 
Vector vectorFromCoordinate = point;
Console.WriteLine($"Implicit conversion: {vectorFromCoordinate.X}, {vectorFromCoordinate.Y}");

Vector vector = new Vector(1.5, 2.8);
Coordinate coordinateFromVector = (Coordinate)vector;
Console.WriteLine($"Explicit conversion: {coordinateFromVector.X}, {coordinateFromVector.Y}");



