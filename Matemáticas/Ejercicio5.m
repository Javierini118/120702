clc
%Funcion Polinomial, Grado 5 
f=@(x)x^5.*x^4+1.*x^3+3.*x^2+6.*x-4.* -10;
%Gráfica  de la función x: [0,1,+3+6-4-10]
fplot(f);
%Agregar Cuadrícula a la gráfica, título y nombre  a ejes
grid on; 
title   ("f(x)= x^5 + 1x^4 + 3x^3 + 6x^2 -4x -10");
xlabel  ("x");
ylabel ("y");
%Encontrar los Ceros de la función
% Coeficientes  de la funcion f(x):
p=[0 1 3 6 -4 -10];
r=roots(p);
disp("los ceros de la función f(x) son:")
disp(r)