Description:

Taken From : http://www.reddit.com/r/dailyprogrammer/comments/3840rp/20150601_challenge_217_easy_lumberjack_pile/

The famous lumberjacks of /r/dailyprogrammer[1] are well known to be weird and interesting. But we always enjoy solving their problems with some code.
For today's challenge the lumberjacks pile their logs from the forest in a grid n x n. Before using us to solve their inventory woes they randomly just put logs in random piles. Currently the pile sizes vary and they want to even them out. So let us help them out.
Input:

You will be given the size of the storage area. The number of logs we have to put into storage and the log count in each pile currently in storage. You can either read it in from the user or hardcode this data.
Input Example:
 3
 7
 1 1 1
 2 1 3
 1 4 1
 
So the size is 3 x 3. We have 7 logs to place and we see the 3 x 3 grid of current size of the log piles.
Log Placement:

We want to fill the smallest piles first and we want to evenly spread out the logs. So in the above example we have 7 logs. The lowest log count is 1. So starting with the first pile in the upper left and going left-right on each row we place 1 log in each 1 pile until all the current 1 piles get a log. (or until we run out). After that if we have more logs we then have to add logs to piles with 2 (again moving left-right on each row.)
Keep in mind lumberjacks do not want to move logs already in a pile. To even out the storage they will do it over time by adding new logs to piles. But they are also doing this in an even distribution.
Once we have placed the logs we need to output the new log count for the lumberjacks to tack up on their cork board.
Output:

Show the new n x n log piles after placing the logs evenly in the storage area.
Using the example input I would generate the following:
example output:
 3 2 2
 2 2 3
 2 4 2
