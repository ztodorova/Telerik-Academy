/**
 Problem 1. Planar coordinates

 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.
 */
console.log('Problem 1. Planar coordinates');

function createPoint(xcoordinate, ycoordinate) {
    return {
        x: xcoordinate,
        y: ycoordinate
    }
}

function createLine(point1, point2) {
    return {
        startPoint: point1,
        endPoint: point2,
        length: distance(point1, point2),
    }
}

function distance(point1, point2) {
    //var d = Math.sqrt( (x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) );
    var dis = Math.sqrt((point1.x - point2.x)) * (point1.x - point2.x) + (point1.y - point2.y) * (point1.y - point2.y);
    return dis;
}

function canFormTriangle(line1, line2, line3) {
    if ((line1.length + line2.length > line3.length) &&
        (line1.length + line3.length > line2.length) &&
        (line2.length + line3.length > line1.length)) {
        return true;
    } else {
        return false;
    }
}

var formTriangle,
    point1 = createPoint(1, 2),
    point2 = createPoint(3, 4),
    point3 = createPoint(5, 5),
    point4 = createPoint(7, 8),
    point5 = createPoint(3, 4),
    point6 = createPoint(5, 6),
    line1 = createLine(point1, point2),
    line2 = createLine(point3, point4),
    line3 = createPoint(point5, point6);

console.log('line1' +'(('+point1.x+','+point1.y+'),('+point2.x+','+point2.y+'))');
console.log('line2' +'(('+point3.x+','+point3.y+'),('+point4.x+','+point4.y+'))');
console.log('line3' +'(('+point5.x+','+point5.y+'),('+point6.x+','+point6.y+'))');
formTriangle = canFormTriangle(line1, line2, line3);
console.log('Can form a triangle -> ' + formTriangle);

console.log('*****************************************');


