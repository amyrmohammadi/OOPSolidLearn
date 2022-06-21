using LearnOOP;

//var startPoint=new ThreeDPoint(3,5,6);

var startPoint=new ThreeDPoint();
startPoint.X=3;
startPoint.Y=5;
startPoint.Z=7;

// var endPoint=new ThreeDPoint();
// endPoint.X=3;
// endPoint.Y=5;
// endPoint.Z=4;

var endPoint=startPoint with {Z=4};

var resPoint=startPoint + endPoint;

var resPoint2=resPoint.AddPoint(startPoint);
Console.WriteLine(resPoint2.ToString());
Console.WriteLine(resPoint.ToString());

