import React from 'react';
import Header from '../components/Header';

const DashboardPage = () => {
  return (
    <div className="flex flex-col min-h-screen bg-gray-100">
      <Header />
      <main className="flex-grow flex items-center justify-center">
        <h1 className="text-5xl font-extrabold">Starcatcher</h1>
      </main>
    </div>
  );
};

export default DashboardPage;