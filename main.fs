module Assignment

// Problem 1
let rec prod (lst:int list) =
   if List.isEmpty lst
   then 1
   else (List.head lst) * (prod (List.tail lst)) 
        
   

// Problem 2
let rec map f (lst:int list) =
    if List.isEmpty lst
    then []
    else (f(List.head lst))::(map f (List.tail lst))
    
    

// Problem 3
let rec odd (lst:int list) =
  if List.isEmpty lst 
  then []
  else
      let a = List.head lst
      let b = List.tail lst
      if a % 2 = 1
      then a :: ( odd b )
      else odd b
   

// Problem 4
let rec filter f lst =
  if List.isEmpty lst 
  then []
  else 
      let a = List.head lst
      let b = List.tail lst
      if f a 
      then a :: (filter f a)
      else filter f b

 
