
#include "catch.hpp"
#include "Calculator.h"
using namespace std;


TEST_CASE( "Calculator/opsplus", "операция сложения + " ) {
    Calculator c;
    c.store(3);
    double result1 = c.handleOperation(Calculator::ADD);
    REQUIRE( result1 == Approx(3) );
    c.store(2);
    double result2 = c.equalsPressed();
    REQUIRE( result2 == Approx(5) );
}

TEST_CASE( "Calculator/opsminus", "операция вычитания - " ) {
    Calculator c;
    c.store(3);
    double result1 = c.handleOperation(Calculator::SUBTRACT);
    REQUIRE( result1 == Approx(3) );
    c.store(2);
    double result2 = c.equalsPressed();
    REQUIRE( result2 == Approx(1) );
}

TEST_CASE( "Calculator/opstimes", "операция умножения * " ) {
    Calculator c;
    c.store(3);
    double result1 = c.handleOperation(Calculator::MULTIPLY);
    REQUIRE( result1 == Approx(3) );
    c.store(2);
    double result2 = c.equalsPressed();
    REQUIRE( result2 == Approx(6) );
}

TEST_CASE( "Calculator/opsdivide", "операция деления / " ) {
    Calculator c;
    c.store(3);
    double result1 = c.handleOperation(Calculator::DIVIDE);
    REQUIRE( result1 == Approx(3) );
    c.store(2);
    double result2 = c.equalsPressed();
    REQUIRE( result2 == Approx(1.5) );
}


TEST_CASE( "Calculator/equalsChain", "выполнение одной функции несколько раз" ) {
    //" 3 + 2 = = " should make 7
    Calculator c;
    c.store(3);
    double result1 = c.handleOperation(Calculator::ADD);
    REQUIRE( result1 == Approx(3) );
    c.store(2);
    double result2 = c.equalsPressed();
    REQUIRE( result2 == Approx(5) );
    double result3 = c.equalsPressed();
    REQUIRE( result3 == Approx(7) );
}

TEST_CASE( "Calculator/sqrRoot", "квадратный корень" ) {
    //" 9 - root(16) --> 5"
    Calculator c;
    c.store(9);
    double result1 = c.handleOperation(Calculator::SUBTRACT);

    c.store(16);
    double result2 = c.handleOperation(Calculator::SQRT);
    REQUIRE( result2 == Approx(4) );

    double result3 = c.equalsPressed();
    REQUIRE( result3 == Approx(5) );
}
