using Nazarovv2;

var timer = new CountDown();

var subscriberA = new Subscriber(timer, "Субскрубер А");
var subscriberB = new Subscriber(timer, "Субскрубер Б");
var subscriberC = new Subscriber(timer, "Субскрубер Ц");

timer.Skip(1000, "вот вам событие");
timer.Skip(1000, "вот вам второе событие");
subscriberA.Ubsubscribe();
timer.Skip(2000, "вот вам третье событие");
subscriberB.Ubsubscribe();
timer.Skip(1000, "вот вам четвертое событие");
subscriberC.Ubsubscribe();
timer.Skip(1000, "вот вам пятое событие");