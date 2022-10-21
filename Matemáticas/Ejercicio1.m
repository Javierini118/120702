clc
%Funcion Polinomial, Grado 1 
f=@(x)x+4.*-2;
%Gráfica  de la función x: [4,-2]
fplot(f);
%Agregar Cuadrícula a la gráfica, título y nombre  a ejes
grid on; 
title   ("f= 4x -2");
xlabel  ("x");
ylabel ("y");
%Encontrar los Ceros de la función
% Coeficientes  de la funcion f(x):
p=[1 4 -2 ];
r=roots(p);
disp("los ceros de la función f(x) son:")
disp(r)