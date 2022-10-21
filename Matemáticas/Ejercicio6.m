clc
%Funcion Polinomial, Grado 6 
f=@(x)x^6 +18.*x^5-24.*x^4+10.*x^3+71.*x^2+6.*x-4.* +10;
%Gráfica  de la función x: [0,1,+3+6-4-10]
fplot(f);
%Agregar Cuadrícula a la gráfica, título y nombre  a ejes
grid on; 
title   ("f(x)= 18 x^6 -24 x^5 + 10 x^4 + 71 x^3 + 6x^2 -4x +10");
xlabel  ("x");
ylabel ("y");
%Encontrar los Ceros de la función
% Coeficientes  de la funcion f(x):
p=[18 -24 10 71 6 -4 10];
r=roots(p);
disp("los ceros de la función f(x) son:")
disp(r)