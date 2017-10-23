select distinct city from station
where city in (select city from station where left(city, 1) in('a', 'e', 'i', 'o', 'u'))
