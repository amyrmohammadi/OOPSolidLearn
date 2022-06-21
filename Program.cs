using LearnOOP;

//var startDot=new ThreeDDot(3,5,6);

var startDot=new ThreeDDot();
startDot.X=3;
startDot.Y=5;
startDot.Z=7;

// var endDot=new ThreeDDot();
// endDot.X=3;
// endDot.Y=5;
// endDot.Z=4;

var endDot=startDot with {Z=4};

var resDot=startDot + endDot;

Console.WriteLine(resDot.ToString());



