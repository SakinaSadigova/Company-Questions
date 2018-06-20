# Company-Questions

## Answers

5. Aşağıdakı sintaksislərdən hansı səhfdir?

 int k = 5;
 int g = 'A';
 int j = k + g;
 // A hərfinin unicode qarşılığı g dəyişəninə implicit olaraq casting olunur ve normal int dəyəri kimi toplama əməliyyatı yerinə  yetirilir.

  int k = 5;
  char g =13; // casting error baş verəcək. Yuxarıda qeyd etdiyim kimi, int tipinə chardan implicit cast dəsdəklənir.Amma, chara intdən     explicit casting tələb olunur. 

  string k = "r";
  char g = 'A';
  string j = k + g;//"+" operatoru stringdə concatination(birləşdirmə) prosesini həyata keçirdiyi üçün g dəyişəni burada string olaraq k      ilə birləşir.
  
  int k = 629;
  string g = "A";
  string j = k + g;//Yuxarıdakı kimi birləşdirmə əməliyyatı yerinə yetiriləcək və heç bir xəta baş verməyəcək
