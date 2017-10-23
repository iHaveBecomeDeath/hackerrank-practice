select city, length(city) as shortlen 
from station 
order by shortlen asc, city asc
limit 1;
select city, length(city) as longlen 
from station 
order by longlen desc, city asc
limit 1;
