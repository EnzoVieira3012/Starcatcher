import { createSlice } from '@reduxjs/toolkit';

const initialState = {
  clients: [],
};

const clientSlice = createSlice({
  name: 'clients',
  initialState,
  reducers: {
    setClients: (state, action) => {
      state.clients = action.payload;
    },
    addClient: (state, action) => {
      state.clients.push(action.payload);
    },
    removeClient: (state, action) => {
      state.clients = state.clients.filter(client => client.id !== action.payload);
    },
  },
});

export const { setClients, addClient, removeClient } = clientSlice.actions;

export default clientSlice.reducer;