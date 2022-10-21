clc
%Funcion Polinomial, Grado 2 
f=@(x)x^2+25.*x+15.*-16;
%Gráfica  de la función x: [25,-16]
fplot(f);
%Agregar Cuadrícula a la gráfica, título y nombre  a ejes
grid on; 
title   ("f(x)= 25x^2 +15x -16");
xlabel  ("x");
ylabel ("y");
%Encontrar los Ceros de la función
% Coeficientes  de la funcion f(x):
p=[25 15 1];
r=roots(p);
disp("los ceros de la función f(x) son:")
disp(r)